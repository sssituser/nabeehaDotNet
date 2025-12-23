import axios from "axios";
import React from "react";
import { Link,useNavigate } from "react-router-dom";
export default function Login() {
    let navigate = useNavigate();
    let[login, setLogin]=React.useState({
        id:'',
        password:''
    });

    function loginUser(e){
        e.preventDefault();
       axios.get(`http://localhost:9000/users?id=${login.id}&password=${login.password}`)
       .then((response)=>{
            if(response.data.length>0){ 
                
                alert('Logged in Successfully');
                localStorage.setItem('id',login.id);
                navigate('/employees');
            }
            else{
                alert('Invalid Credentials');
            }
        })
    }
    function updateInput(e){
        setLogin({
            ...login,
            [e.target.name]:e.target.value
        })
    }
    return(
        <React.Fragment>
            <div className="container">
                <div className="row mt-5 justify-content-center">
                    <div className="col-md-4">
                        <div className="card">
                            <div className="card-header bg-primary text-white">
                                <p className="h3">Login Here</p>
                            </div>
                            <div className="card-body">
                                <form action="" onSubmit={loginUser}>
                                     
                                    <div className="form-group">
                                       <input type='text' onChange={updateInput} value={login.id}  name="id" className="form-control" placeholder="Enter User Name" />

                                    </div>
                                     <div className="form-group">
                                       <input type='password' onChange={updateInput} value={login.password}  name="password" className="form-control" placeholder="Enter Password" />
                                       
                                    </div>
                                    <Link to='/register' className="btn btn-sm btn-outline-primary float-left rounded-pill">Register Here</Link>
                                    <button className="btn btn-sm btn-outline-success rounded-pill float-right">Login</button>
                                    
                                </form>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </React.Fragment>
    )
}