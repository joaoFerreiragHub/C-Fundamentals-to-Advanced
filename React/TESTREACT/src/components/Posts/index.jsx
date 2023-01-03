
import { Fragment } from 'react';
import "./styles.css";
import { PostCard } from '../PostCard';


export const Posts = ({posts}) => (

<div className="posts">
{
posts.map((post) => 

<Fragment key={post.id}>
    <PostCard post={post}/>
</Fragment>
)}
</div>
);

