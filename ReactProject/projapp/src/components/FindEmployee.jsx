import axios from 'axios'
import React, { useEffect, useState } from 'react'
import { useParams,Link } from 'react-router-dom'
const FindEmployee = () => {
    let{ id} = useParams()
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
  return (
    <React.Fragment>
        <div className="container mt-5">
            <div className="row">
                <div className="col-md-8">
                    <div className="card">
                        <div className="card-header bg-secondary text-white text-center">
                            <p className="h3">Employee Info</p>
                        </div>
                        <div className="card-body">
                            <div className="row">
                                <div className="col-md-4">
                                 <img src={employee.eimage} className='img-fluid' alt="" />
                                </div>
                                <div className="col-md-6 mt-2">
                                 <ul className='list-group'>
                                    <li className='list-group-item'>
                                       <span className='font-weight-bold'>Employee ID</span> {employee.eid}
                                    </li>
                                    <li className='list-group-item'>
                                        <span className='font-weight-bold'>Employee Name </span>{employee.ename}
                                    </li>
                                    <li className='list-group-item'>
                                       <span className='font-weight-bold'>Employee Salary </span> {employee.esal}
                                    </li>
                                 </ul>
                                </div>
                            </div>
                        </div>
                        <div className="card-footer">
                            <Link to='/' className='btn btn-warning btn-md'>Back</Link>
                            <Link to={`/edit/${employee.id}`} className='btn btn-primary btn-md float-right' >Edit</Link>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </React.Fragment>
  )
}

export default FindEmployee