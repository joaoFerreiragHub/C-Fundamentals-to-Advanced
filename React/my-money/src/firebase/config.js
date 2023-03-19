import firebase from "firebase/app";
import "firebase/firestore";
import "firebase/auth";

const firebaseConfig = {
  apiKey: "AIzaSyDmHAm-BoSwD-pfJ7kn2uvBSxvNqBeV6JQ",
  authDomain: "mymoney-8ae7b.firebaseapp.com",
  projectId: "mymoney-8ae7b",
  storageBucket: "mymoney-8ae7b.appspot.com",
  messagingSenderId: "856857661633",
  appId: "1:856857661633:web:dc43627a2733bcaffbc440",
};

//init firebase

firebase.initializeApp(firebaseConfig);

const projectFirestore = firebase.firestore();
const projectAuth = firebase.auth();

//timestamp

const timestamp = firebase.firestore.Timestamp;

export { projectFirestore, projectAuth, timestamp };
