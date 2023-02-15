import { Component } from '@angular/core';
import { Store } from '@ngrx/store';
import { counterEvents } from 'src/app/state/actions/counter.actions';

@Component({
  selector: 'app-counter-prefs',
  templateUrl: './counter-prefs.component.html',
  styleUrls: ['./counter-prefs.component.css']
})
export class CounterPrefsComponent {

  constructor(private store: Store) { }

  setCountBy(by: number) {
    this.store.dispatch(counterEvents.countBySet({ by }))
  }
}
