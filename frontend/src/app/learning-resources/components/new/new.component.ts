import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ItemCreate } from '../../state/actions/items.actions';
import { ItemType } from '../../state/reducers/items.reducer';

@Component({
  selector: 'app-new',
  templateUrl: './new.component.html',
  styleUrls: ['./new.component.css']
})
export class NewComponent {
  options = ['Book', 'Video', 'Blog', 'Tutorial', 'Other'];

  form = new FormGroup<ItemCreateForm>({
    description: new FormControl<string>('', {
      nonNullable: true,
      validators: [
        Validators.required
      ]
    }),
    type: new FormControl<ItemType>('Other', { nonNullable: true }),
    link: new FormControl<string>('', {
      nonNullable: true,
      validators: [
        Validators.required,
        Validators.maxLength(50),
        Validators.minLength(5)
      ]
    })

  });

  addItem() {
    // this is where we will dispatch the action
    console.log(this.form.valid);
    console.log(this.form.value);
  }
}



type FormDataType<T> = {
  [Property in keyof T]: FormControl<T[Property]>
}

type ItemCreateForm = FormDataType<ItemCreate>;

// export type ItemType = 'Book' | 'Video' | 'Blog' | 'Tutorial' | 'Other';

