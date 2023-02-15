import { Component } from '@angular/core';
import { Store } from '@ngrx/store';
import { selectCounterCurrent } from 'src/app/state';

@Component({
  selector: 'app-counter',
  templateUrl: './counter.component.html',
  styleUrls: ['./counter.component.css']
})
export class CounterComponent {

  // Current is an observable
  current$ = this.store.select(selectCounterCurrent)
  constructor(private store: Store) { }

  increment() {

  }

  decrement() {

  }
}
