import { useEffect, useState } from "react";
import Template from "../components/Template";
import Swal from "sweetalert2";
import axios from "axios";
import config from "../config";

function UserProfile(){
const [name, setName] = useState('');
const [usr, setUsr] = useState('');
const [pwd, setPwd] = useState('');

useEffect(()=>{
    fetchData();
},[])

const fetchData = async () =>{
    try {
        await axios.post(config.api+'/api/User/GetInfo',null,config.headers).then(res=>{
            setName(res.data.name);
            setUsr(res.data.usr);
        }).catch(err=>{
            throw err.response.data;
        })
    } catch (e){
        Swal.fire({
            title: 'error',
            text: e.message,
            icon: 'error'
        })
    }
}

const handleSave = async (e)=>{
    e.preventDefault();
    try{
        const params ={
            name: name,
            usr: usr,
            pwd: pwd
        }
        await axios.post(config.api + '/api/User/ChangeProfileSave',
        params,config.headers).then(res=>{
            if (res.data.message === 'Update success'){
                Swal.fire({
                    title: 'บันทึกข้อมูล',
                    text: 'บันทึกข้อมูลสำเร็จ',
                    icon: 'success',
                    timer: 1000
                });
            }
        })
    } catch (e){
        Swal.fire({
            title: 'error',
            text: e.message,
            icon: 'error'
        })
    }
}

    return (
        <Template>
            <div className="h5">แก้ไขข้อมูลส่วนตัว</div>
            <div className="card">
                <form onSubmit={handleSave} className="card-body">
                    <div>ชื่อ</div>
                    <input value={name} onChange={e=> setName(e.target.value)} className="form-control"/>
                                
                    <div className="mt-2">username</div>
                    <input value={usr} onChange={e=> setUsr(e.target.value)} className="form-control"/>
                    
                    <div className="mt-2">password</div>
                    <input value={pwd} onChange={e=> setPwd(e.target.value)} className="form-control"/>

                    <button onClick={handleSave} className="btn btn-primary mt-3">
                        <i className="fa fa-check" style={{marginRight:'10px'}} ></i>
                        Save
                    </button>
                </form>
            </div>
        </Template>
    )
}
export default UserProfile;