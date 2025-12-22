import axios from 'axios'
import React, { useEffect, useState } from 'react'
import { useParams,Link,useNavigate } from 'react-router-dom'
const EditEmployee = () => {
     let navigate =useNavigate();
    let{id} = useParams()
    let[employee,setEmployee]=useState({})
   
    useEffect(()=>{
        axios.get(`http://localhost:9000/employees/${id}`)
        .then((response)=>{
            setEmployee(response.data)
           
        })
        .catch((error)=>{
            alert(error)
        })
    },[])

    function updateInput(event){
        setEmployee({
            ...employee,
            [event.target.name]:event.target.value
        })
    }
    function save(event){
        event.preventDefault()
        axios.put(`http://localhost:9000/employees/${id}`,employee)
        .then(()=>{
            alert("Employee Updated")
            navigate('/')
        })
        .catch((error)=>{
            alert(error)
        })
    }
  return (
    <React.Fragment>
        <div className="container mt-5">
            <div className="row">
                <div className="col-md-12">
                    <div className="card">
                        <div className="card-header bg-success text-white text-center">
                            <p className="h3">Edit Employee Info</p>
                        </div>
                         <form action="" onSubmit={save}>
                        <div className="card-body">
                            
                           <div className="row">
                                <div className="col-md-4">
                                    <img src={employee.eimage} className='img-fluid' alt="" />
                                </div>
                                <div className="col-md-6 mt-3">
                               
                                <div className="form-group">
                                    <input type="text" name="eid" value={employee.eid} className='form-control'/>
                                </div>
                                <div className="form-group">
                                    <input type="text" name='ename'onChange={updateInput} value={employee.ename} className='form-control'/>
                                </div>
                                <div className="form-group">
                                    <input type="number" name='esal' onChange={updateInput} value={employee.esal} className='form-control'/>
                                </div>
                                <div className="form-group">
                                    <input type="text" name='eimage' onChange={updateInput} value={employee.eimage} className='form-control'/>
                                </div>
                                </div>
                           </div>
                        </div>
                        <div className="card-footer">
                            <Link to='/' className='btn btn-warning btn-md'>Back</Link>
                            <button className='btn btn-md btn-success float-right'>Save</button>
                        </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </React.Fragment>
  )
}

export default EditEmployee