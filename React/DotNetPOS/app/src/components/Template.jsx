import Navbar from "../components/Navbar";
import Sidebar from "../components/Sidebar";
function Template(props) {
    return (
        <>
            <div className="wrapper">
                <Navbar />
                <Sidebar />

                <div class="content-wrapper">
                    <section class="content">
                        {props.children}
                    </section>
                </div>
            </div>
        </>
    )
}

export default Template;