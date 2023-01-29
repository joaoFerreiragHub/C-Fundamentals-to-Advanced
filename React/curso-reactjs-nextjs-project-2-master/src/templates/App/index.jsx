import './styles.css';
import { Home } from '../Home/index';
import { PostsProvider } from '../../contexts/PostsProvider';
import { Posts } from '../../components/Posts';
import { CounterProvider } from '../../contexts/CounterProvider';
import { useEffect } from 'react';
import { useHistory } from 'react-router-dom/cjs/react-router-dom.min';

export function App() {
  return (
    <CounterProvider>
      <PostsProvider>
        <div>
          {/* <Posts /> */}
          <Home />
        </div>
      </PostsProvider>
    </CounterProvider>
  );
}
