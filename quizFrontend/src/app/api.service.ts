import { Injectable } from "@angular/core";
import {HttpClient} from '@angular/common/http';


@Injectable()
export class ApiService{
    

    constructor(private http: HttpClient){}

    getQuestions(){
        return this.http.get('https://localhost:44353/api/question');
    }

    postQuestion(question: any){
        this.http.post('https://localhost:44353/api/question', question).subscribe(res=>{
            console.log(res);
        })
    }

    

}