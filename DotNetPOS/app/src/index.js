import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
//import App from './App';
import reportWebVitals from './reportWebVitals';
import { createBrowserRouter, RouteProvider,} from 'react-router-dom';
import Login from './pages/Login';

const router = createBrowserRouter([
  {
    path: "/",
    element: <Login />,
  },
]);

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <React.StrictMode>
      <RouteProvider router={router}/>
  </React.StrictMode>
);

reportWebVitals();
