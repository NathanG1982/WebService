import {Injectable} from '@angular/core';
import {HttpClient, HttpHeaders} from "@angular/common/http";
import {Observable} from "rxjs";
import {environment} from "../../../environments/environment";
import {catchError} from "rxjs/operators";
import {of} from "rxjs/observable/of";

@Injectable()
export class CalculatorService {

  private readonly _url: string;

  constructor(
    private http: HttpClient
  ) {
    this._url = `${environment.api}/calculator`;
  }

  public calc(operand: string, numbers: number[]): Observable<number> {
    const headers: HttpHeaders = new HttpHeaders();

    headers.append('Content-Type', "application/json");

    return this.http.post<number>(`${this._url}/calc`, {numbers: numbers, operand: operand}, {
      headers: headers
    })
      .pipe(
        catchError(err => {
          console.error(err);
          return of(NaN);
        })
      );
  }
}
