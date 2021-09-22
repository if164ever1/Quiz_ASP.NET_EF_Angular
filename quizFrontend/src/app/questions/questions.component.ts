import { Component, OnInit } from '@angular/core';
import { ApiService } from '../api.service';



@Component({
  selector: 'app-questions',
  templateUrl: './questions.component.html',
  styleUrls: ['./questions.component.css']
})
export class QuestionsComponent{

  question: any = {};

  constructor(private api: ApiService ){}

  ngOnInit(){
    this.api.getQuestions().subscribe(res => {
      console.log(res);
    });
  }

  Post(question:string){
    this.api.postQuestion(question);
  }
}
