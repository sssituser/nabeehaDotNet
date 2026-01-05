import React from "react";
export default function SecondComponent(props) {
  return (
    <React.Fragment>
      <div className="container bg-warning mt-5 p-5">
        <p className="h1 text-center text-success">SecondComponent.jsx</p>
        <h2 className="text-danger text-center">This is Second Component</h2>
        <h3 className="text-dark text-center">Name : {props.sname}</h3>
        <h3 className="text-warning text-center">Age : {props.sage}</h3>
      </div>
    </React.Fragment>
  );
}