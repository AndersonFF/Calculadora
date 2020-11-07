import { Request } from './../models/request.model';
import { Component, Inject, Injectable } from '@angular/core';
import { HttpClient, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs';
import { CodigoOperacao } from '../models/codigooperacao.enum';

@Injectable()
export class ApiService {

   protected baseUrl: string = "https://localhost:44312/calculadora";

  constructor(private http: HttpClient) { }
   
  calcular({numero1, numero2, operacao}: Request): Observable<number> {
    return this.http.post<any>(this.baseUrl, { Valor1: +numero1, Valor2: +numero2, Operador: +operacao });
  }
  
  calcularSoma({numero1, numero2, operacao}: Request): Observable<number> {
    return this.http.post<any>(this.baseUrl+'/somar', { Valor1: +numero1, Valor2: +numero2, Operador: +CodigoOperacao.Soma });
  }
  
  calcularSubtracao({numero1, numero2, operacao}: Request): Observable<number> {
    return this.http.post<any>(this.baseUrl+'/subtrair', { Valor1: +numero1, Valor2: +numero2, Operador: +CodigoOperacao.Subtracao });
  }
  
  calcularMultiplicacao({numero1, numero2, operacao}: Request): Observable<number> {
      return this.http.post<any>(this.baseUrl+'/multiplicar', { Valor1: +numero1, Valor2: +numero2, Operador: +CodigoOperacao.Multiplicacao });
  }

  calcularDivisao({numero1, numero2, operacao}: Request): Observable<number> {
    return this.http.post<any>(this.baseUrl+'/dividir', { Valor1: +numero1, Valor2: +numero2, Operador: +CodigoOperacao.Divisao });
}
 
}
