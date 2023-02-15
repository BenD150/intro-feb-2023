import { Component } from '@angular/core';
import { Store } from '@ngrx/store';
import { CountByValues, counterEvents } from 'src/app/state/actions/counter.actions';

@Component({
  selector: 'app-counter-prefs',
  templateUrl: './counter-prefs.component.html',
  styleUrls: ['./counter-prefs.component.css']
})
export class CounterPrefsComponent {

  constructor(private store: Store) { }

  setCountBy(by: CountByValues) {
    this.store.dispatch(counterEvents.countBySet({ by }))
  }
}
