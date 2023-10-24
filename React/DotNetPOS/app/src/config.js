const Config = {
    api: 'http://localhost:5242',
    headers: {
        headers:{
            Authorization: 'Bearer ' + localStorage.getItem('token')
        }
    }
}
export default Config;