import React, { useState } from 'react'
import {BrowserRouter,Routes,Route} from 'react-router-dom';

import AddEmployee from './components/AddEmployee'
import Employoees from './components/Employees';
import EditEmployee from './components/EditEmployee';
import FindEmployee from './components/FindEmployee';

function App() {
  return (
    <React.Fragment>
      <BrowserRouter>
          <Routes>
            <Route path='/' element={<Employoees/>}/>
             <Route path='/add' element={<AddEmployee/>}/>
             <Route path='/edit/:id' element={<EditEmployee/>}/>
             <Route path='/view/:id' element={<FindEmployee/>} />
          </Routes>
      </BrowserRouter>
    </React.Fragment>
  )
}

export default App
