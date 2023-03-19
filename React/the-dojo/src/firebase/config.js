import firebase from "firebase/app";
import "firebase/firestore";
import "firebase/auth";
import "firebase/storage";

const firebaseConfig = {
  apiKey: "AIzaSyBTjzswpb88FmPGvtQ0LqFaorMRuCMf7ww",
  authDomain: "thedojosite-2d4c7.firebaseapp.com",
  databaseURL:
    "https://thedojosite-2d4c7-default-rtdb.europe-west1.firebasedatabase.app",
  projectId: "thedojosite-2d4c7",
  storageBucket: "thedojosite-2d4c7.appspot.com",
  messagingSenderId: "126322786430",
  appId: "1:126322786430:web:5fa4d7efa4782e5af5d82f",
};

// init

firebase.initializeApp(firebaseConfig);

// init services

const projectFirestore = firebase.firestore();
const projectAuth = firebase.auth();
const projectStorage = firebase.storage();

// timestamp
const timestamp = firebase.firestore.Timestamp;

export { projectFirestore, projectAuth, projectStorage, timestamp };
