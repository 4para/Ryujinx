from ubuntu:20.04
workdir /opt
run mkdir -p /opt/4para/Ryujinx
run apt-get -y update 
run apt-get -y -f install ffmpeg
add ./virtualgl_2.6.90_amd64.deb /tmp/
run apt-get -y -f install /tmp/virtualgl_2.6.90_amd64.deb
run rm /tmp/virtualgl_2.6.90_amd64.deb
run apt-get -y -f install libgtk-3-dev
add ./Ryujinx/bin/Debug/net5.0/linux-x64/publish  /opt/4para/Ryujinx
add ./names.txt /opt/4para/Ryujinx
cmd NAMES_PATH=/opt/4para/Ryujinx/names.txt /opt/VirtualGL/bin/vglrun -d ${VGL_X} -c rgb /opt/4para/Ryujinx/Ryujinx -r ${USER_DIR} --fullscreen ${GAME_PATH}

