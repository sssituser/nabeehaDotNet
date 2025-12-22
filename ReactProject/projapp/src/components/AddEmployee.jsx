import React from "react";
import {useForm} from 'react-hook-form'
import axios from 'axios';
import { useNavigate ,Link } from "react-router-dom";
export default function AddEmployee() {
    let navigate =useNavigate();
    const {register,handleSubmit,formState:{errors}}=useForm();
    function save(employee){
        alert(JSON.stringify(employee))
        axios.post('http://localhost:9000/employees',employee)
        .then(()=>{
            alert("Employee Added Successfully.....")
            navigate('/')
        })
        .catch((error)=>{
            alert(error)
        })
    }
    return(
        <React.Fragment>
          <div className="container">
            <div className="row mt-lg-5">
                <div className="col-md-5">
                    <div className="card">

                        <div className="card-header bg-secondary text-white text-center">
                             <p className="h1">Add Employee</p>
                        </div>
                        <div className="card-body">
                            <form action="" onSubmit={handleSubmit(save)}>
                                <div className="form-group">
                                    <input type="number" 
                                    placeholder="Enter ID"
                                     className="form-control"
                                     {
                                        ...register('eid',{
                                            required:{value:true,message:'Id required'},
                                            min:{value:111,message:"Min value is 111"},
                                            max:{value:1000,message:"Ma value is 1000"}
                                        })
                                     }
                                    />
                                    {errors.eid && (<p className="text-danger">{errors.eid.message}</p>)}
                                </div>
                                <div className="form-group">
                                    <input type="text" 
                                    placeholder="Enter Name"
                                     className="form-control"
                                     {
                                        ...register('ename',{
                                            required:{value:true,message:'Name required'},
                                            minLength:{value:5,message:"Minin 5 chars Required"},
                                            maxLength:{value:40,message:"Max 40 chars Required"}
                                        })
                                     }
                                    />
                                    {errors.ename && (<p className="text-danger">{errors.ename.message}</p>)}
                                </div>
                                <div className="form-group">
                                    <input type="number" 
                                    placeholder="Enter Salary"
                                     className="form-control"
                                     {
                                        ...register('esal',{
                                            required:{value:true,message:'Salary is required'},
                                            min:{value:20000,message:"Min Sal is 20k"},
                                            max:{value:5000000,message:"Max Sal is 50L"}
                                        })
                                     }
                                    />
                                    {errors.esal && (<p className="text-danger">{errors.esal.message}</p>)}
                                </div>
                                <div className="form-group">
                                    <input type="text" 
                                    placeholder="Enter Image Address"
                                     className="form-control"
                                     {
                                        ...register('eimage',{
                                            required:{value:true,message:'Image required'},
                                            
                                        })
                                     }
                                    />
                                    {errors.eimage && (<p className="text-danger">{errors.eimage.message}</p>)}
                                </div>
                                <button className="btn btn-md btn-outline-secondary">Submit</button>
                                <Link to={'/'} className="btn btn-md btn-outline-danger float-right">Back</Link>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
          </div>

        </React.Fragment>
    )
}