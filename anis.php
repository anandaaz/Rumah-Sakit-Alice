<?php

// create function to display anis
function display_anis() {
    // connect to database
    $db = new PDO('mysql:host=localhost;dbname=wideworldimporters', 'root', '');
    // set up query
    $sql = "SELECT * FROM anis";
    // run query and store result
    $result = $db->query($sql);
    // loop through results and display
    while ($row = $result->fetch()) {
        echo "<p>";
        echo $row['AniName'] . " " . $row['AniType'];
        echo "</p>";
    }
}
