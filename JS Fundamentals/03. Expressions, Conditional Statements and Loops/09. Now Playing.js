function nowPlaying(input) {
    let song = input[0]
    let singer = input[1]
    let duration = input[2]

    console.log(`Now Playing: ${singer} - ${song} [${duration}]`)
}

nowPlaying(['Number One', 'Nelly', '4:09'])