import { ApiService } from '../../services/api.service';
import { Component, OnInit } from '@angular/core';
import { Request } from '../../models/request.model';
import { FormBuilder, FormGroup } from '@angular/forms';
import { CodigoOperacao } from 'src/app/models/codigooperacao.enum';



@Component({
  selector: 'app-calculadora',
  templateUrl: './calculadora.component.html'
})
export class CalculadoraComponent implements OnInit{
  public type: string;
  public message: string;

  public request: Request = new Request();
  public resultado: number;

  calculadora: Request;
  calculadoraForm: FormGroup;


  constructor(private _apiService: ApiService) { }
    
  ngOnInit(): void {  this.limpar();}

  private alert(type: string, message: string = ''): void {
    this.type = type;
    this.message = message;
  }

  public calcular(): void {
    this._apiService.calcular(this.request)
      .subscribe(response => {
        this.resultado = response;
        this.request = new Request();
        this.alert('success');
      }, error => {
        this.alert('warning', `Ocorreu um erro inesperado, por favor tente novamente`);
      });
  }

  public calcularSoma(): void {
    this.request.Operador = CodigoOperacao.Soma;
    this._apiService.calcularSoma(this.request)
      .subscribe(response => {
        this.resultado = response;
        this.request = new Request();
        this.alert('success');
      }, error => {
        this.alert('warning', `Ocorreu um erro inesperado, por favor tente novamente`);
      });
  }

  public calcularSubtracao(): void {
    this.request.Operador = CodigoOperacao.Subtracao;
    this._apiService.calcularSubtracao(this.request)
      .subscribe(response => {
        this.resultado = response;
        this.request = new Request();
        this.alert('success');
      }, error => {
        this.alert('warning', `Ocorreu um erro inesperado, por favor tente novamente`);
      });
  }
  
  public calcularMultiplicacao(): void {
    this.request.Operador = CodigoOperacao.Multiplicacao;
    this._apiService.calcularMultiplicacao(this.request)
      .subscribe(response => {
        this.resultado = response;
        this.request = new Request();
        this.alert('success');
      }, error => {
        this.alert('warning', `Ocorreu um erro inesperado, por favor tente novamente`);
      });
  }
  
  public calcularDivisao(): void {
    this.request.Operador = CodigoOperacao.Divisao;
    this._apiService.calcularDivisao(this.request)
      .subscribe(response => {
        this.resultado = response;
        this.request = new Request();
        this.alert('success');
      }, error => {
        this.alert('warning', `Ocorreu um erro inesperado, por favor tente novamente`);
      });
  }
  
  limpar() {
    this.resultado = null;
  }



}