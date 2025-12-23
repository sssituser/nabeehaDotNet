import axios from "axios";
import React,{useEffect, useState} from "react";
import { Link,useNavigate } from "react-router-dom";
export default function Employoees(){
    let navigate = useNavigate();
const[employees,setEmployees]=useState([])
const[search,setSearch]=useState('')
useEffect(()=>{
    if(!localStorage.getItem('id')){
        navigate('/');
    }
    display()
},[])
function display(){
    axios.get("http://localhost:9000/employees")
    .then((response)=>{
     setEmployees(response.data)
    })
    .catch((error)=>{
        alert(error)
    })
}
function del(id){
    axios.delete(`http://localhost:9000/employees/${id}`)
    .then(()=>{
        alert("Employee deleted")
        display()
    })
    .catch((error)=>{
        alert(error)
    })
}
function logout(event){
    event.preventDefault();
    localStorage.removeItem('id');
    navigate('/');
}
const filteredEmployees = employees.filter((employee)=>`${employee.eid}${employee.ename}${employee.esal}`.toLowerCase().includes(search.toLowerCase()))

    return(
        <React.Fragment>
            <div className="container">
                
                <section className="mt-lg-5">
                    <p className="lead text-left">Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptatibus numquam sapiente assumenda quos illum mollitia, quod exercitationem neque ratione eum. Autem, magnam consectetur. Corporis et pariatur temporibus deserunt ullam obcaecati aut ipsum porro odio, eaque doloribus sint veritatis rerum ex nihil aliquam iure sapiente, possimus perferendis reprehenderit dolore. Quam voluptatibus nostrum veritatis. Quam dolores quas aut, nobis mollitia nam cumque?</p>
                    <div className="row">
                        <div className="col-md-8">
                            <Link to='/add' className="btn btn-md btn-outline-primary">Add</Link>
                            <span className="text-success">Welcome :{localStorage.getItem('id')}</span>
                            <Link onClick={logout} className="text-primary">Logout</Link>

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
                        filteredEmployees.length>0 ? 
                        <table className="table table-bordered table-hover table-striped text-center">
                            <thead >
                                <tr className="bg-secondary text-white">
                                    <th>ID</th>
                                    <th>EmpID</th>
                                    <th>EmpName</th>
                                    <th>Salary</th>
                                    <th>Picture</th>
                                    <th>Actions</th>
                                </tr>
                            </thead>
                            <tbody>
                                {
                                    filteredEmployees.map((employee)=>{
                                        return(
                                            <tr>
                                            <td>{employee.id}</td>
                                            <td>{employee.eid}</td>
                                            <td>{employee.ename}</td>
                                            <td>{employee.esal}</td>
                                            <td>
                                                <img src={employee.eimage} className="img-thumbnail rounded-circle" style={{width:90,height:90}} alt="" />
                                            </td>
                                            <td>
                                                <Link to={`/view/${employee.id}`}><i className="fa fa-eye fa-2x text-primary mr-3"></i> </Link>
                                                <Link to={`/edit/${employee.id}`} ><i className="fa fa-pen fa-2x  text-warning mr-3"></i></Link>
                                                <Link onClick={()=>del(employee.id)} ><i className="fa fa-trash fa-2x text-danger"></i></Link>
                                            </td>
                                        </tr>
                                        )

                                    })
                                }
                            </tbody>
                        </table>

                        :
                        <p className="h1">EmployeeNot Found</p>
                    }


                </section>  
            </div>
        </React.Fragment>
    )
}