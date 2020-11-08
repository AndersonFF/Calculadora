import { Request } from './../models/request.model';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable()
export class ApiService {

   protected baseUrl: string = "https://localhost:44312/calculadora";

  constructor(private http: HttpClient) { }
   
  calcular(request: Request): Observable<number> {
    return this.http.post<any>(this.baseUrl, request);
  }
  
  calcularSoma(request: Request): Observable<number> {
    return this.http.post<any>(this.baseUrl+'/somar', request);
  }
  
  calcularSubtracao(request: Request): Observable<number> {
    return this.http.post<any>(this.baseUrl+'/subtrair', request);
  }
  
  calcularMultiplicacao(request: Request): Observable<number> {
      return this.http.post<any>(this.baseUrl+'/multiplicar', request);
  }

  calcularDivisao(request: Request): Observable<number> {
    return this.http.post<any>(this.baseUrl+'/dividir', request );
}
 
}
