import { Component } from '@angular/core';

@Component({
  selector: 'app-shopping-list',
  templateUrl: './shopping-list.component.html',
  styleUrls: ['./shopping-list.component.css']
})
export class ShoppingListComponent {

  items: ShoppingItem[] = [
    {description: 'Beer', purchased: false}, 
    {description: 'Buns', purchased: false}, 
    {description: 'Eggs', purchased: true}, 
  ]

}


type ShoppingItem = {
  description:string,
  purchased:boolean
}