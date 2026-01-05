import React,{ useState } from 'react'
import FirstComponent from './components/FirstComponent';
import Demo from './components/Demo';


function App() {
  let [name,setName]=useState("kiran");
  let[age,setAge]=useState(25);
  
  function updateInput(event){
    setName("Ravi");
    setAge(30);
  }
  return (
    <React.Fragment>
        <div className="container bg-light mt-2 p-5 text-center">
          <p className="h1 text-center text-success">functional App.jsx Component</p>
          <p className="h2">Name : {name} </p>
          <p className="h2">Age : {age} </p>
          <button onClick={updateInput}>ChangeData</button>
        <Demo fname={name} age={age}/>
        </div>
    </React.Fragment>
  )
}

export default App
