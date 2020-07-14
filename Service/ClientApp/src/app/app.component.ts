import {Component, OnInit} from '@angular/core';
import {CalculatorService} from "./core/services/calculator.service";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  result: number;

  constructor(
    private calculator: CalculatorService
  ) {

  }

  public calc(operand: string, ...numbers: number[]): void {
    switch (operand) {
      case '+':
      case '-':
      case '*':
      case '/':
        this.calculator.calc(operand, numbers).subscribe(v => this.result = v);
        break;
      default:
        this.result = NaN;
    }
  }

  ngOnInit(): void {
  }
}
