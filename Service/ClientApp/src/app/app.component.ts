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
      // For demo proses shows implicit using sum function
      case '+':
        this.calculator.sum(numbers).subscribe(v => this.result = v);
        break;
      case '-':
      case '*':
      case '/':
        // Other cases will go to generic calc service
        this.calculator.calc(operand, numbers).subscribe(v => this.result = v);
        break;
      default:
        this.result = NaN;
    }
  }

  ngOnInit(): void {
  }
}
