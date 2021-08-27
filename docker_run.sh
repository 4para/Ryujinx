DOCKER_NAME=abc
TMP_DIR=/tmp/yiming
HOST_XAUTH_PATH=/run/user/1000/gdm/Xauthority
HOST_X=1
HOST_DEVICE=/dev/input/event25
IMAGE=docker.4pd.io/liuyiming/test

docker run -it --rm --name ${DOCKER_NAME} \
        --gpus all \
        -e PULSE_SERVER=/tmp/pulseserver \
        -e USER_DIR=/tmp/user \
        -e DISPLAY=:99 \
        -e VGL_X=:${HOST_X} \
        -v ${TMP_DIR}:/tmp \
        -v /tmp/.X11-unix/X${HOST_X}:/tmp/.X11-unix/X1 \
        -v ${HOST_XAUTH_PATH}:/root/.Xauthority \
        --device ${HOST_DEVICE} \
        ${IMAGE}
