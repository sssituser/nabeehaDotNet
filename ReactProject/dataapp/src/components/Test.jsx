import React from "react";
export default class Test extends React.Component {
    
   constructor(props) {
        super(props);
       
       
        this.state = { // defining the state object
            college: "ABC College",
            course: "ReactJS",
            location: "Hyd"
        };
        
    }

    updateInput = (event) => { // changing the state values
        this.setState({
            college: "XYZ College",
            course: "Angular",
            location: "Bangalore"
        });
    }
   
  
    render() {
        return (
            <React.Fragment>
                <div className="container bg-warning  text-center text-white p-3">
                        <p className="h1">Class Test Component</p>
                        <p className="h1">Data from Other components using this.props</p>

                        <p className="h3">Name: {this.props.sname}</p>
                        <p className="h3">Age: {this.props.sage}</p>


                        <p className="h1">The from the local state</p>
                        <p className="h3">College: {this.state.college}</p>
                        <p className="h3">Course: {this.state.course}</p>
                        <p className="h3">Location: {this.state.location}</p>
                        <button onClick={this.updateInput} className="btn btn-primary btn-sm">ChangeData</button>
                </div>
            </React.Fragment>
        );
    }
}