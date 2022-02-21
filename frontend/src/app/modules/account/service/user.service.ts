import { Injectable } from '@angular/core';

import { environment } from '@environments/environment';
import { HttpService } from '@shared/http/http.service';
import { User } from '../model/user.model';

@Injectable({
  providedIn: 'root',
})
export class UserService {
  private resourceURL = `${environment.baseURL}/User`;

  constructor(private http: HttpService) {}

  async get(): Promise<User[] | null> {
    return await this.http.get<User[]>(`${this.resourceURL}`);
  }

  async getMyData(): Promise<User | null> {
    return await this.getById(localStorage.getItem("userId") ?? '');
  }

  async getById(id: string): Promise<User | null> {
    return await this.http.get<User>(`${this.resourceURL}/${id}`);
  }

  async doLogin(username: string, password: string): Promise<User> {
    return await this.http.post<User>(`${this.resourceURL}/login`, {username, password})!
      .catch( response => {
        if(response.status === 401){
          return Promise.reject('Usuário ou senha inválida!');
        }
        return Promise.reject();
      });
  }
}
