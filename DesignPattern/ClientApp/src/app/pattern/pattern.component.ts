import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { FactoryParameter, StrategyParameter } from './patternJsonclass';
import { FactoryReturnClass, StrategyReturnClass } from './patternJsonclass';



@Component({
  selector: 'app-pattern',
  templateUrl: './pattern.component.html',
  styleUrls: ['./pattern.component.css']
})

export class PatternComponent implements OnInit {

  operators = '+' ;
  numberX: number;
  numberY: number;
  httpclient: HttpClient;
  baseUrl: string;
  message: string;

  constructor(Http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.httpclient = Http;
    this.baseUrl = baseUrl;
  }

  onFactoryCalculate() {
    this.FactoryPost();
  }
  onStrategyCalculate() {
    this.StrategyPost();
  }

  FactoryPost() {
    const jsondata: FactoryParameter = new FactoryParameter();
    jsondata.numberX = this.numberX;
    jsondata.numberY = this.numberY;
    jsondata.oper = this.operators;

    this.httpclient.post<FactoryReturnClass>(this.baseUrl + 'api/Pattern/FactoryCalculate', jsondata ).subscribe(result => {
      this.message = result.message.toString() + '.  result = ' + result.result.toString();

    }, error => console.error(error));
  }
  StrategyPost() {
    const jsondata: StrategyParameter = new StrategyParameter();
    jsondata.numberX = this.numberX;
    jsondata.numberY = this.numberY;
    jsondata.oper = this.operators;

    this.httpclient.post<StrategyReturnClass>(this.baseUrl + 'api/Pattern/StrategyCalculate', jsondata ).subscribe(result => {
      this.message = result.message.toString() + '.  result = ' + result.result.toString();

    }, error => console.error(error));
  }
  ngOnInit() {
  }



}



