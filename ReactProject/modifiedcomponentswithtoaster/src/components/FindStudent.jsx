import axios from 'axios'
import React, { useEffect, useState } from 'react'
import { useParams,Link } from 'react-router-dom'
 
function FindStudent() {
    let {id}=useParams()
    let[student,setStudent]=useState({})
   useEffect(()=>{
    axios.get(`http://localhost:9000/students/${id}`)
    .then((res)=>{
        setStudent(res.data)
    }).catch((error)=>{alert(error)})
   },[])
    
  return (
   <React.Fragment>
        <div className="container mt-5">
            <div className="row">
                <div className="col-md-12">
                    <div className="card">
                        <div className="card-header text-center">
                            <p className="h2">Student Info</p>
                          
                        </div>
                        <div className="card-body">
                            <div className="row">
                                <div className="col">
                                   <img src={student.studentImage} alt="" className='img-fluid' height={200} width={200} />
                                </div>
                                <div className="col">
                                    <div className="list-group">
                                        <li className="list-group-item borderless">
                                            <b>ID :</b> {id}
                                        </li>
                                        <li className="list-group-item borderless">
                                            <b>NAME :</b> {student.studentName}
                                        </li>
                                        <li className="list-group-item borderless">
                                            <b>CONTACT :</b> {student.studentContact}
                                        </li>
                                        <li className="list-group-item borderless">
                                            <b>EMAIL :</b> {student.studentEmail}
                                        </li>
                                        <li className="list-group-item borderless">
                                           
                                        </li>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div className="card-footer">
                            <Link to='/' className='btn btn-warning btn-md'>Back</Link>
                            <Link to={`/edit/${student.id}`} className='btn btn-primary btn-md float-right'>Edit</Link>
                        </div>
                    </div>
                </div>
            </div>
        </div>
 
   </React.Fragment>
  )
}
 
export default FindStudent
 

 