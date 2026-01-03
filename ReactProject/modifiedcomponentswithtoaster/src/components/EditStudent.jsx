import React, { useState, useEffect } from 'react'
import axios from 'axios'
import { useNavigate, useParams } from 'react-router-dom'
import { Link } from 'react-router-dom'
 
function EditStudent() {
    let {id} =useParams()
    let navigate= useNavigate()
    let[student,setStudent]=useState({
        studentName: '',
        studentContact: '',
        studentEmail:'',
        studentImage:''
    })
  
    useEffect(()=>{
        axios.get(`http://localhost:9000/students/${id}`)
        .then((response)=>{
            setStudent(response.data)
            
        })
        .catch((error)=>{
            alert(error?.message || error)
        })
    },[id])
   
    function updateInput(event){
    
        setStudent({
            ...student,
            [event.target.name] :[event.target.value]
        })
    }
    function save(event){
        event.preventDefault()
        axios.put(`http://localhost:9000/students/${id}`,student)
        .then(()=>{
            alert('student updated')
            navigate('/')
        })
        .catch((error)=>{
            alert('error' +error)
        })
    }
 
  return (
    <React.Fragment>
        <div className="container mt-5">
            <div className="row">
                <div className="col-md-12">
                    <div className="card">
                        <div className="card-header bg-success text-white text-xenter">
                            <p className="h1">Edit Student Details</p>
                        </div>
                        <form action="" onSubmit={save}>
                            <div className="card-body">
                                <div className="row">
                                    <div className="col-md-4">
                                        <img src={student.image} className='img-fluid' alt=""></img>
                                    </div>
                                    <div className="col-md-8">
                                        <div className="form-group">
                                            <input type="number" name='id' className='form-control' value={student.id} />
                                        </div>
                                        <div className="form-group">
                                            <input type="text" name='studentName'
                                            className='form-control' value={student.studentName} onChange={updateInput}/>
                                        </div>
                                         <div className="form-group">
                                            <input type="number" name='studentContact' className='form-control' value={student.studentContact} onChange={updateInput}/>
                                        </div>
                                        <div className="form-group">
                                            <input type="email" name='studentEmail' placeholder='email' className='form-control' value={student.studentEmail} onChange={updateInput}/>
                                        </div>
                                         <div className="form-group">
                                            <input type="text" name='studentImage' placeholder='image url' className='form-control' value={student.studentImage} onChange={updateInput}/>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div className="card-footer">
                                <Link to='/'className='btn btn-warning btn-md'>Back</Link>
                                 <button className='btn btnn-md btn-success float-right'>Save</button>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </React.Fragment>
  )
}
 
export default EditStudent
 