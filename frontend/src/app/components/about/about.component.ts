import { Component } from '@angular/core';
import { Observable } from 'rxjs';
import { StatusResponseModel } from 'src/app/models/status.models';
import { StatusDataService } from 'src/app/services/status-data.service';

@Component({
  selector: 'app-about',
  templateUrl: './about.component.html',
  styleUrls: ['./about.component.css']
})
export class AboutComponent {

  responseFromServer$!: Observable<StatusResponseModel>;

  constructor(private service: StatusDataService) { }

  getStatus() {

    this.responseFromServer$ = this.service.getStatus();

  }
}


