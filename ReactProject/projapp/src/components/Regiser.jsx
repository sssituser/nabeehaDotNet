import axios from "axios";
import React from "react";
import { Link,useNavigate } from "react-router-dom";
export default function Register() {
    let navigate  = useNavigate();
    let[login, setLogin]=React.useState({
        id:'',
        password:''
    });

    function updateInput(e){
        setLogin({
            ...login,
            [e.target.name]:e.target.value
        })
    }
    function register(e){
        e.preventDefault();
        axios.post("http://localhost:9000/users",login)
        .then(()=>{
            alert('Registered Successfully')
            navigate('/');
        })
        .catch((error)=>{
            alert(error);
        });
    }
    return(
        <React.Fragment>
            <div className="container">
                <div className="row mt-5 justify-content-center">
                  
                    <div className="col-md-4">
                        <div className="card">
                            <div className="card-header bg-secondary text-white">
                                <p className="h3">Register Here</p>
                            </div>
                            <div className="card-body">
                                <form action="" onSubmit={register}>
                                     
                                    <div className="form-group">
                                       <input type='text' onChange={updateInput} value={login.id}  name="id" className="form-control" placeholder="Enter User Name" />

                                    </div>
                                     <div className="form-group">
                                       <input type='password' onChange={updateInput} value={login.password}  name="password" className="form-control" placeholder="Enter Password" />
                                       
                                    </div>
                                    <Link to='/' className="text-secondary float-left rounded-pill">login Here</Link>
                                    <button className="btn btn-sm btn-outline-success rounded-pill float-right">SignUp</button>
                                </form>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </React.Fragment>
    )
}