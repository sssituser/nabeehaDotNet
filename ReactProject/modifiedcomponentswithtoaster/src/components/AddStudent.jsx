import React from 'react'
import { useForm } from 'react-hook-form'
import axios from 'axios';
import { useNavigate, Link } from 'react-router-dom'
import { toast } from 'react-toastify'
function AddStudent() {
  const navigate = useNavigate()
  const {register, handleSubmit, reset, formState: { errors }} = useForm()
  function save(student) {
      alert(JSON.stringify(student))
      axios.post('http://localhost:9000/students', student)
      .then(()=>{
        alert('Student added successfully')
        toast.success('Success Message!')
        reset()
        navigate('/')
      })
      .catch((error)=>{
      alert(error)
      })
    }

  return (
    <React.Fragment>
    <div className="container mt-5">
      <div className="col-md-6">
        <div className="card">
          <div className="card-header bg-primary text-white text-center">
            <h2>Add Student</h2>
          </div>

          <div className="card-body">
            <form onSubmit={handleSubmit(save)}>
            <input type="number" className="form-control mb-2" placeholder="Enter ID"
                {
                    ...register('id', 
                    {
                      required: 'ID is required', 
                      min: { value: 111, message: 'Min value is 111' },
                      max: { value: 99999, message: 'Max value is 99999' }
                    })}
            />
            {errors.id && <p className="text-danger">{errors.id.message}</p>}

            <input type="text" className="form-control mb-2" placeholder="Name"
                {
                    ...register('studentName', 
                    {
                       required: 'Name is required',
                       minLength: { value: 3, message: 'Min 3 characters' },
                       maxLength: { value: 10, message: 'Max 10 characters' }
                    })}
            />
            {errors.studentName && (<p className="text-danger">{errors.studentName.message}</p>)}

            <input type="text" className="form-control mb-2" placeholder="Contact"
                {
                    ...register('studentContact', 
                    {
                      required: 'Contact is required',
                      pattern: {
                      value: /^\d{10,11}$/,
                      message: 'Contact must be 10 or 11 digits'
                      }
                    })}
              />
              {errors.studentContact && (
                <p className="text-danger">{errors.studentContact.message}</p>
              )}

             
              <input type="email" className="form-control mb-3" placeholder="Email"
                {
                    ...register('studentEmail', 
                    {
                      required: 'Email is required',
                      pattern: {
                      value: /^[^\s@]+@[^\s@]+\.[^\s@]+$/,
                      message: 'Enter valid email address'
                      }
                    })}
              />
              {errors.studentEmail && (
                <p className="text-danger">{errors.studentEmail.message}</p>
              )}

              <input type="text" className="form-control mb-3" placeholder="ImageUrl"
                {
                    ...register('studentImage', 
                    {
                      required: 'Image is required',
                    
                    })}
              />


              <button type="Submit" className="btn btn-success">Submit</button>
              <Link to={'/'} className="btn btn-md btn-outline-danger float-right">Back</Link>
            </form>
          </div>
        </div>
      </div>
    </div>

    </React.Fragment>
  )
}

export default AddStudent
