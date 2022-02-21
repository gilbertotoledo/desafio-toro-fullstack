export const SPB_EVENTS_URI = '/spb/events';

export const TRANSFER_EVENT_CORRECT = {
  event: "TRANSFER",
  target: {
    bank: "352",
    branch: "0001",
    account: "300123",
  },
  origin: {
    bank: "033",
    branch: "03312",
    cpf: "11111111111",
  },
  amount: 1000,
};

export const DEPOSIT_EVENT = {
  event: "DEPOSIT",
  target: {
    bank: "352",
    branch: "0001",
    account: "300123",
  },
  origin: {
    bank: "033",
    branch: "03312",
    cpf: "45358996060",
  },
  amount: 1000,
};

export const TRANSFER_EVENT_WITHOUT_AMOUNT = {
  event: "TRANSFER",
  target: {
    bank: "352",
    branch: "0001",
    account: "300123",
  },
  origin: {
    bank: "033",
    branch: "03312",
    cpf: "45358996060",
  },
};

export const TRANSFER_EVENT_WITH_NEGATIVE_AMOUNT = {
    event: "TRANSFER",
    target: {
      bank: "352",
      branch: "0001",
      account: "300123",
    },
    origin: {
      bank: "033",
      branch: "03312",
      cpf: "45358996060",
    },
    amount: -100,
  };

export const TRANSFER_EVENT_WITHOUT_ORIGIN = {
  event: "TRANSFER",
  target: {
    bank: "352",
    branch: "0001",
    account: "300123",
  },
  amount: 1000,
};

export const TRANSFER_EVENT_WITHOUT_TARGET = {
  event: "TRANSFER",
  origin: {
    bank: "033",
    branch: "03312",
    cpf: "45358996060",
  },
  amount: 1000,
};

export const TRANSFER_EVENT_WITH_NONEXISTENT_ACCOUNT = {
  event: "TRANSFER",
  target: {
    bank: "352",
    branch: "0001",
    account: "987654",
  },
  origin: {
    bank: "033",
    branch: "03312",
    cpf: "45358996060",
  },
  amount: 1000,
};

export const TRANSFER_EVENT_WITH_CPF_DIFFERENT = {
  event: "TRANSFER",
  target: {
    bank: "352",
    branch: "0001",
    account: "123",
  },
  origin: {
    bank: "033",
    branch: "03312",
    cpf: "22222222222",
  },
  amount: 1000,
};
