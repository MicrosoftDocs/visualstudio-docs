---
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Explore the Solar System</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            background: linear-gradient(to bottom, #0b3d91, #000000);
            color: white;
        }
        header {
            background-color: #111;
            padding: 20px;
            text-align: center;
        }
        nav {
            background-color: #222;
            padding: 10px;
            text-align: center;
        }
        nav a {
            color: #ffd700;
            text-decoration: none;
            margin: 15px;
            font-weight: bold;
        }
        section {
            padding: 40px;
        }
        .card {
            background-color: rgba(255, 255, 255, 0.1);
            padding: 20px;
            margin: 20px 0;
            border-radius: 10px;
        }
        footer {
            background-color: #111;
            text-align: center;
            padding: 15px;
        }
        button {
            padding: 10px 15px;
            background-color: #ffd700;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            font-weight: bold;
        }
    </style>
    <script>
        function showMessage() {
            alert("Keep exploring and never stop learning about space!");
        }
    </script>
</head>
<body>

<header>
    <h1> Explore the Solar System</h1>
    <p>Learn about our amazing planetary neighborhood!</p>
</header>

<nav>
    <a href="#about">About</a>
    <a href="#planets">Planets</a>
    <a href="#funfacts">Fun Facts</a>
</nav>

<section id="about">
    <h2>About the Solar System</h2>
    <div class="card">
        <p>
            The Solar System consists of the Sun and everything that orbits around it,
            including eight planets, moons, asteroids, and comets.
            The Sun is the center and provides light and heat to all planets.
        </p>
    </div>
</section>

<section id="planets">
    <h2>The Eight Planets</h2>
    <div class="card">
        <ul>
            <li>Mercury</li>
            <li>Venus</li>
            <li>Earth</li>
            <li>Mars</li>
            <li>Jupiter</li>
            <li>Saturn</li>
            <li>Uranus</li>
            <li>Neptune</li>
        </ul>
    </div>
</section>

<section id="funfacts">
    <h2>Fun Facts</h2>
    <div class="card">
        <p> The Sun makes up 99.8% of the Solar System’s mass.</p>
        <p>Jupiter is the largest planet.</p>
        <p>Earth is the only known planet with life.</p>
        <button onclick="showMessage()">Click for Inspiration</button>
    </div>
</section>

<footer>
    <p>Made by: Aeisha Bernadette Del Rosario and Eunice S. Uy</p>
</footer>

</body>
</html>
