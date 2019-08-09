import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  registerMode = false;
  selectedUser = false;
  currentUser: any;
  userTodoList: any;
  users: any;
  todos: any;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getUsers();
    this.getTodo();
  }

  registerToggle() {
    this.registerMode = !this.registerMode;
  }

  userToggle() {
    this.selectedUser = !this.selectedUser;
    if (this.todos) {
      this.todos.forEach((todo: any) => {
        this.userTodoList.push(todo);
      });
    }
  }

  todoToggle() {

  }

  cancelRegisterMode(registerMode: boolean) {
    this.registerMode = registerMode;
  }

  getUsers( ) {
    this.http.get('http://localhost:5000/api/users/').subscribe(response => {
      this.users = response;
    }, error => {
      console.log(error);
    });
  }

  getTodo( ) {
    this.http.get('http://localhost:5000/api/todos/').subscribe(response => {
      this.todos = response;
    }, error => {
      console.log(error);
    });
  }
}
