import { Asset } from './asset.model';
import { CheckingAccount } from "./checking-account.model";

export interface User{
  id: string,
  name: string,
  username: string,
  cpf: string,
  checkingAccount: CheckingAccount;
  assets?: Asset[];
  desposits: any[];
}
