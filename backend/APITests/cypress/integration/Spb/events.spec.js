/// <reference types="cypress" />
import {
  SPB_EVENTS_URI,
  TRANSFER_EVENT_CORRECT,
  DEPOSIT_EVENT,
  TRANSFER_EVENT_WITHOUT_AMOUNT,
  TRANSFER_EVENT_WITHOUT_TARGET,
  TRANSFER_EVENT_WITHOUT_ORIGIN,
  TRANSFER_EVENT_WITH_NEGATIVE_AMOUNT,
  TRANSFER_EVENT_WITH_NONEXISTENT_ACCOUNT,
  TRANSFER_EVENT_WITH_CPF_DIFFERENT,
} from "../../fixtures/factory/spbEvents";

context("SPB Events", () => {
  it("Send correct event should receive success message", () => {
    cy.sendPostExpectOk(SPB_EVENTS_URI, TRANSFER_EVENT_CORRECT);
  });

  it("Send event with invalid EventName should fail", () => {
    cy.sendPostExpectBadRequest(SPB_EVENTS_URI, DEPOSIT_EVENT).then(
      (response) => {
        expect(response).property("body").to.be.eq("Invalid event name");
      }
    );
  });

  it("Send event without amount should fail", () => {
    cy.sendPostExpectBadRequest(
      SPB_EVENTS_URI,
      TRANSFER_EVENT_WITHOUT_AMOUNT
    ).then((response) => {
      expect(response).property("body").to.be.contains("Amount cannot be zero");
    });
  });

  it("Send event with negative amount should fail", () => {
    cy.sendPostExpectBadRequest(
      SPB_EVENTS_URI,
      TRANSFER_EVENT_WITH_NEGATIVE_AMOUNT
    ).then((response) => {
      expect(response).property("body").to.be.contains("Amount must be zero or greater");
    });
  });

  it("Send event without target should fail", () => {
    cy.sendPostExpectBadRequest(
      SPB_EVENTS_URI,
      TRANSFER_EVENT_WITHOUT_TARGET
    ).then((response) => {
      expect(response).property("body").to.be.contains("Target cannot be null.");
    });
  });

  it("Send event without origin should fail", () => {
    cy.sendPostExpectBadRequest(
      SPB_EVENTS_URI,
      TRANSFER_EVENT_WITHOUT_ORIGIN
    ).then((response) => {
      expect(response).property("body").to.be.contains("Origin cannot be null.");
    });
  });

  it("Send event with nonexistent account should fail", () => {
    cy.sendPostExpectBadRequest(
      SPB_EVENTS_URI,
      TRANSFER_EVENT_WITH_NONEXISTENT_ACCOUNT
    ).then((response) => {
      expect(response).property("body").to.be.eq("Account not found or CPF source is different from destination");
    });
  });

  it("Send event with CPF destination different from origin should fail", () => {
    cy.sendPostExpectBadRequest(
      SPB_EVENTS_URI,
      TRANSFER_EVENT_WITH_CPF_DIFFERENT
    ).then((response) => {
      expect(response).property("body").to.be.eq("Account not found or CPF source is different from destination");
    });
  });
});
