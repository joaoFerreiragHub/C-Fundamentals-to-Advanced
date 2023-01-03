import React from 'react'

import "./styles.css";


export  const PostCard = ({post}) =>{

    return (
        <div className="post">
          <img src={post.cover} style={{width:"100%"}} alt={post.title} />
          <div key={post.id} className="post-content">
            <h1>{post.title}</h1>
            <p>{post.body}</p>
          </div>
        </div>
      )
}

