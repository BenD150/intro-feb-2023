// The "Application State"

import { ActionReducerMap, createFeatureSelector, createSelector } from "@ngrx/store";
import * as fromCounter from './reducers/counter.reducer'

export interface AppState {
    counter: fromCounter.CounterState
};


export const reducers: ActionReducerMap<AppState> = {
    counter: fromCounter.reducer
}


// 1. Create a "feature selector"
const selectCounterFeature = createFeatureSelector<AppState>("counter");


// 2. Create a selector per branch of the state
const selectCounterBranch = createSelector(
    selectCounterFeature,
    f => f.counter
)


// 3. Any helpers (optional)

// 4. What does the component need
// We need a selector that returns the current of the counter.

export const selectCounterCurrent = createSelector(
    selectCounterBranch,
    (f => f.current)
)