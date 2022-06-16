import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Post } from './posts/post';

@Injectable({
  providedIn: 'root'
})
export class ServpostsService {

  private urlAPI="https://jsonplaceholder.typicode.com/posts";

  constructor(private http: HttpClient) { }

  getPosts() {
    return this.http.get<Post[]>(this.urlAPI);
  }
}
