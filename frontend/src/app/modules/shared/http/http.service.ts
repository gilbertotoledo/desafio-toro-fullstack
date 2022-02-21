import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { from as observableFromPromise, lastValueFrom } from 'rxjs';
import { map, take } from 'rxjs/operators';

@Injectable()
export class HttpService {
  headers: any;

  constructor(private httpClient: HttpClient) {
    this.headers = {
      headers: new HttpHeaders()
        .append('Content-Type', 'application/json')
        //.append('Authorization', 'Bearer ' + authorizationToken),
    };
  }

  public get<T>(url: string, options?: any): Promise<T> | null {
    return this.doRequest<T>(() =>
      this.httpClient.get<T>(url, { ...options, ...this.headers })
    );
  }

  public post<T>(url: string, body: any, options?: any): Promise<T> | null {
    return this.doRequest<T>(() =>
      this.httpClient.post<T>(url, body, { ...options, ...this.headers })
    );
  }

  public async put<T>(url: string, body: any, options?: any): Promise<T | null> {
    return await this.doRequest<T>(() =>
      this.httpClient.put<T>(url, body, { ...options, ...this.headers })
    );
  }

  private async doRequest<T>(fn: Function) {
    return await lastValueFrom<T>(
      fn().pipe(
        take(1),
        map((response: any) => response)
      )
    );
  }
}
