import { Component, OnInit } from '@angular/core';
import { ServpostsService } from '../servposts.service';
import { Post } from './post';

@Component({
  selector: 'app-posts',
  templateUrl: './posts.component.html',
  styleUrls: ['./posts.component.css']
})
export class PostsComponent implements OnInit {

  listaPosts : Post[] | null = [];

  constructor(private servposts: ServpostsService) { }

  ngOnInit(): void {
    this.servposts.getPosts().subscribe(posts => {
      this.listaPosts=posts;
      console.log(this.listaPosts);
    });
  }

}
