import React from 'react';
import ReactDOM from 'react-dom/client';
import reportWebVitals from './reportWebVitals';
import { createBrowserRouter, RouterProvider } from "react-router-dom";
import Login from './pages/Login';
import Home from './pages/Home';
import UserProfile from './pages/UserProfile';

const router = createBrowserRouter([
  {
    path: "/",
    element: <Login />,
  },
  {
    path: '/home',
    element: <Home />
  },
  {
    path: '/changeProfile',
    element: <UserProfile />
  }
]);

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(

  <RouterProvider router={router} />

);

reportWebVitals();
