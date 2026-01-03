import axios from "axios";
import React,{useEffect, useState} from "react";
import { Link,useNavigate } from "react-router-dom";
import { toast } from "react-toastify";
export default function Studentlist(){
let navigate = useNavigate();
const[students,setStudents]=useState([])
const[search,setSearch]=useState('')
useEffect(()=>{
    display()
},[])
function display(){
    axios.get("http://localhost:9000/students")
    .then((response)=>{
     setStudents(response.data)
    })
    .catch((error)=>{
        alert(error)
    })
}
function del(id){

    axios.delete(`http://localhost:9000/students/${id}`)
    .then(()=>{
       
        toast.error('Student Deleted',{autoClose:1000})
        display()
    })
    .catch((error)=>{
        alert(error)
    })
}

const filteredStudents = students.filter((student)=>`${student.id}${student.studentName}${student.studentEmail}`.toLowerCase().includes(search.toLowerCase()))

    return(
        <React.Fragment>
            <div className="container">
                
                <section className="mt-lg-5">
                    <p className="lead text-left">Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptatibus numquam sapiente assumenda quos illum mollitia, quod exercitationem neque ratione eum. Autem, magnam consectetur. Corporis et pariatur temporibus deserunt ullam obcaecati aut ipsum porro odio, eaque doloribus sint veritatis rerum ex nihil aliquam iure sapiente, possimus perferendis reprehenderit dolore. Quam voluptatibus nostrum veritatis. Quam dolores quas aut, nobis mollitia nam cumque?</p>
                    <div className="row">
                        <div className="col-md-8">
                            <Link to='/add' className="btn btn-md btn-outline-primary">Add</Link>
                        </div>
                        <div className="col-md-4">
                            <input type="text" placeholder="Search" 
                            name='search'
                            value={search}
                            onChange={(event)=>{setSearch(event.target.value)}}
                            className="form-control" />
                        </div>
                    </div>
                </section>  
                <section>
                    
                    {
                        filteredStudents.length>0 ? 
                        <table className="table table-bordered table-hover table-striped text-center">
                            <thead >
                                <tr className="bg-secondary text-white">
                                    <th>ID</th>
                                    <th>StudentName</th>
                                    <th>StudentEmail</th>
                                    <th>StudentContact</th>
                                    <th>Stuent Pic</th>
                                    <th>Actions</th>
                                </tr>
                            </thead>
                            <tbody>
                                {
                                    filteredStudents.map((student)=>{
                                        return(
                                            <tr>
                                            <td>{student.id}</td>
                                            <td>{student.studentName}</td>
                                            <td>{student.studentEmail}</td>
                                            <td>{student.studentContact}</td>
                                            <td>
                                                <img src={student.studentImage} className="img-thumbnail rounded-circle" style={{width:90,height:90}} alt="" />
                                            </td>
                                            <td>
                                                <Link to={`/view/${student.id}`}><i className="fa fa-eye fa-2x text-primary mr-3"></i> </Link>
                                                <Link to={`/edit/${student.id}`} ><i className="fa fa-pen fa-2x  text-warning mr-3"></i></Link>
                                                <Link onClick={()=>del(student.id)} ><i className="fa fa-trash fa-2x text-danger"></i></Link>
                                            </td>
                                        </tr>
                                        )

                                    })
                                }
                            </tbody>
                        </table>

                        :
                        <p className="h1">Stuents Not Found</p>
                    }


                </section>  
            </div>
        </React.Fragment>
    )
}