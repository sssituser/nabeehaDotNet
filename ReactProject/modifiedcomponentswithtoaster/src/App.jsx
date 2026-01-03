import React from "react";
import useCounter from "./useCounter";
import Studentlist from "./components/Studentlist";
import {BrowserRouter,Routes,Route} from 'react-router-dom'
import AddStudent from "./components/AddStudent";
import FindStudent from "./components/FindStudent";
import EditStudent from "./components/EditStudent";
import { ToastContainer } from 'react-toastify'
import 'react-toastify/dist/ReactToastify.css'
export default function App(){
  const[count,increment,decrement,reset]=useCounter();

  return(

    <React.Fragment>
     <BrowserRouter>
      <ToastContainer />
      <Routes>
        <Route path="/" element={<Studentlist/>}/>
        <Route path="/add" element={<AddStudent/>}/>
        <Route path="/view/:id" element={<FindStudent/>}/>
        <Route path="/edit/:id" element={<EditStudent/>}/>
      </Routes>
     </BrowserRouter>
    </React.Fragment>
  )
}