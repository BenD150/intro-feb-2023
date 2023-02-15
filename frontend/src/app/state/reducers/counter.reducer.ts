import { createReducer } from "@ngrx/store";

// Tell typescript about it
export interface CounterState {
    current: number;
}


// What should this have when the application starts up
const initialState: CounterState = {
    current: 0
}


// write a function that is responsible for this branch of the application state.
// this function gets a readonly copy of the current state, and any actions that have been dispatched
// and it can return a new state.
export const reducer = createReducer(initialState);