import Navbar from "../components/Navbar";  
import Sidebar from "../components/Sidebar";
import Template from "../components/Template";
function Home() {
    const token = localStorage.getItem('token');
    return (
        <>
        <Template>
            <div>Home</div>
        </Template>
        </>
    )
}

export default Home; 