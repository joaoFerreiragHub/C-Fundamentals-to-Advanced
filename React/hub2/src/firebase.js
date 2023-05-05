import firebase from "firebase";

const firebaseConfig = {
  apiKey: "AIzaSyCXm6x2SKjzryFynl9cE-4b0j0NQpHFm3c",
  authDomain: "react-579cc.firebaseapp.com",
  projectId: "react-579cc",
  storageBucket: "react-579cc.appspot.com",
  messagingSenderId: "836714742935",
  appId: "1:836714742935:web:c20c19c7296ae86c7195d2",
};

const firebaseApp = firebase.initializeApp(firebaseConfig);
const db = firebaseApp.firestore();
const auth = firebase.auth();

export { auth };
export default db;
