import { Component } from '@angular/core';
import { Store } from '@ngrx/store';

@Component({
  selector: 'app-counter',
  templateUrl: './counter.component.html',
  styleUrls: ['./counter.component.css']
})
export class CounterComponent {
  current = 0;
  //current$ = this.store.select();
  constructor(private store: Store) { }

  increment() {
    this.current += 1;
  }

  decrement() {
    this.current -= 1;
  }
}