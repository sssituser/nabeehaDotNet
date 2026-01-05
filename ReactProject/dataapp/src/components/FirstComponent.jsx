import React from "react";
import SecondComponent from "./SecondComponent";
export default function FirstComponent(props) {

  return (
    <React.Fragment>
      <div className="container bg-info mt-5 p-5">
        <p className="h1 text-center text-white">FirstComponent.jsx</p>
        <h2 className="text-secondary text-center">This is First Component</h2>
        <h3 className="text-warning text-center">Name : {props.fname}</h3>
        <h3 className="text-warning text-center">Age : {props.fage}</h3>
        <SecondComponent sname={props.fname} sage={props.fage} />
      </div>
    </React.Fragment>
  );
}