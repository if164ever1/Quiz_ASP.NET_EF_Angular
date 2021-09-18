import { Component, OnInit } from '@angular/core';
import { ApiService } from '../api.service';

@Component({
  selector: 'app-question',
  templateUrl: './question.component.html',
  styleUrls: ['./question.component.css']
})
export class QuestionComponent {
  question: any = {};

  constructor(private api: ApiService ){}

  Post(question:string){
    this.api.postQuestion(question);
  }

}
