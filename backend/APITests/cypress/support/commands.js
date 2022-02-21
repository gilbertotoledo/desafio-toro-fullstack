import { HEADERS } from '../fixtures/factory/dataUtils';

Cypress.Commands.add("sendPostExpectOk", (resourceRoute, body) => {
    cy.request({
        method: "POST",
        url: resourceRoute,
        headers: HEADERS,
        body: body,
    }).then((response) => {
        expect(response).property("status").to.equal(200);
        return response;
    });
});

Cypress.Commands.add("sendPostExpectBadRequest", (resourceRoute, body) => {
    cy.request({
        method: "POST",
        url: resourceRoute,
        headers: HEADERS,
        body: body,
        failOnStatusCode: false
    }).then((response) => {
        expect(response).property("status").to.equal(400);
        return response;
    });
});