import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class GetDataService {

  constructor(

    private http: HttpClient
    ) {}
  getAll<T>(url:string): Observable<T> {
    return this.http
      .get<T>(`${url}`, {
        params: new HttpParams(),
      })
  }
//http://localhost:3000/News
  // private _errorHandler(error: HttpErrorResponse) {
  //   this._ErrorService.handler(error.message)
  //   return throwError(() => error.message);
  // }
  // post<T>(data: T, url: string): Observable<T> {
  
  //   return this.http.post<T>(`${url}`, data)
  // }

}
