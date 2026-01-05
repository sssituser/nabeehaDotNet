
import React  from "react";
import Test from "./Test";

export default class Demo extends React.Component {
    render() {
        return (
            <React.Fragment>
                <div className="container bg-primary  text-center text-white p-3">
                        <p className="h1">Class Demo Component</p>
                        <p className="h3">Name: {this.props.fname}</p>
                        <p className="h3">Age: {this.props.age}</p>


                        
                        <Test sname={this.props.fname} sage={this.props.age}/>
                </div>
            </React.Fragment>
        )
    }
}
    